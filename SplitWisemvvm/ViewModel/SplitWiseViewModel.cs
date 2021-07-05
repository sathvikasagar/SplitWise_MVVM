using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Input;
using SplitWisemvvm.Model;

namespace SplitWisemvvm.ViewModel
{
    public class SplitWiseViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Person> _person { get; set; }

        public ICommand AddPerson { get; set; }

        public ICommand Calculate { get; set; }

        public ICommand NewGroup { get; set; }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChange("Name");
            }
        }

        private string spent;
        public string Spent
        {
            get { return spent; }
            set
            {
                spent = value;
                RaisePropertyChange("Spent");
            }
        }

        private string share;
        public string Share
        {
            get { return share; }
            set
            {
                share = value;
                RaisePropertyChange("Share");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChange(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        public SplitWiseViewModel()
        {
            this._person = new ObservableCollection<Person>();

            this.AddPerson = new RelayCommand((parameter) => {
                _person.Add(new Person(this.Name, float.Parse(this.Spent), float.Parse(this.Share)));
                Name = "";
                Spent = "";
                Share = "";
            });

            this.Calculate = new RelayCommand((parameter) => {
                int count = _person.Count;
                var output = new List<string>();

                float totalAmount = 0;
                for (int i = 0; i < count; i++)
                {
                    totalAmount += _person[i].Spent;
                }

                for (int i = 0; i < count; i++)
                {
                    float toBeRecieved = (_person[i].Spent - (totalAmount * _person[i].Share) / 100);
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
            });

            this.NewGroup = new RelayCommand((parameter) => {
                for (int i = _person.Count - 1; i >= 0; i--)
                {
                    _person.RemoveAt(i);
                }
            });
        }


    }
}
