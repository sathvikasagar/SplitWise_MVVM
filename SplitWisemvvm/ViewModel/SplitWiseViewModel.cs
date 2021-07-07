using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Input;
using SplitWisemvvm.Model;

namespace SplitWisemvvm.ViewModel
{
    public class SplitWiseViewModel : Person
    {
        public ObservableCollection<Person> _person { get; set; }

        public ICommand AddPerson { get; set; }

        public ICommand Calculate { get; set; }

        public ICommand NewGroup { get; set; }

        public ICommand Remove { get; set; }

        private Person itemSelected;

        public SplitWiseViewModel():base("","","")
        {
            this._person = new ObservableCollection<Person>();

            this.AddPerson = new RelayCommand(_addPerson,disableAdd);

            this.Calculate = new RelayCommand(_calculate);

            this.NewGroup = new RelayCommand(_newGroup);

            this.Remove = new RelayCommand(_remove,disableRemove);
        }

        public void _addPerson(object parameter)
        {
            if(Spent=="" && Share=="")
            {
                MessageBox.Show("plese enter amount spent and share");
            }
            else if(Spent == "" || Share == "")
            {
                if(Spent == "")
                {
                    MessageBox.Show("plese enter amount spent");
                }
                else if(Share == "")
                {
                    MessageBox.Show("plese enter share");
                }
            }
            else
            {
                _person.Add(new Person(Name, Spent, Share));
                Name = "";
                Spent = "";
                Share = "";
            }
        }
        public  bool disableAdd(object parameter)
        {
            if(Name == "")
            {
                return false;
            }
            return true;
        }

        public void _calculate(object parameter)
        {
            int count = _person.Count;
            var output = new List<string>();

            float totalShare = 0;
            float totalAmount = 0;
            for (int i = 0; i < count; i++)
            {
                totalAmount += float.Parse(_person[i].Spent);
                totalShare += float.Parse(_person[i].Share);
            }
            if(totalShare==100)
            {
                for (int i = 0; i < count; i++)
                {
                    float toBeRecieved = (float.Parse(_person[i].Spent) - (totalAmount * float.Parse(_person[i].Share)) / 100);
                    string message = "";
                    if (toBeRecieved < 0)
                    {
                        message = _person[i].Name + " should pay " + Math.Abs(toBeRecieved).ToString();
                    }
                    else
                    {
                        message = _person[i].Name + " should recieve " + Math.Abs(toBeRecieved).ToString();
                    }
                    output.Add(message);
                }
                var op = string.Join(Environment.NewLine, output);
                MessageBox.Show(op);
            }
            else
            {
                MessageBox.Show("Total sum of share percentage should be equal to 100 per group");
            }
        }

        public void _newGroup(object parameter)
        {
            for (int i = _person.Count - 1; i >= 0; i--)
            {
                _person.RemoveAt(i);
            }
        }

        public Person ItemSelected
        {
            get
            {
                return itemSelected;
            }
            set
            {
                this.itemSelected = value;
            }
        }

        public void _remove(object parameter)
        {
            _person.Remove(this.itemSelected);
        }

        public bool disableRemove(object parameter)
        {
            if(this.itemSelected==null)
            {
                return false;
            }
            return true;
        }
    }
}
