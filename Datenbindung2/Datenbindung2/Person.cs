using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Datenbindung2
{
  class Person : INotifyPropertyChanged
  {
    public string Name { get; set; }
    public string Wohnort { get; set; }
    private int alter;
    public int Alter
    {
      get
      {
        return alter;
      }

      set
      {
        if (alter == value) return;
        alter = value;

        OnPropertyChanged();
        OnPropertyChanged(nameof(IstErfahren));
      }
    }

    public bool IstErfahren
    {
      get
      {
        return Alter > 40;
      }
    }

    protected void OnPropertyChanged([CallerMemberName]string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler PropertyChanged;
  }

  class Firma
  {
    public string Name { get; set; } = "Hinz & Kunz";
    public ObservableCollection<Person> Mitarbeiter { get; set; } = new ObservableCollection<Person>
    {
      new Person { Name="Petra Meier", Wohnort="Berlin", Alter=35},
      new Person { Name="Uwe Keks", Wohnort="München", Alter=33},
      new Person { Name="Maria-Magdalena Müller-Schulze-Ernst", Wohnort="Köln", Alter=44},
      new Person { Name="Udo Schröder", Wohnort="Zürich", Alter=55},
      new Person { Name="Claudi Wohlfahrt", Wohnort="Wien", Alter=29}
    };
  }
}
