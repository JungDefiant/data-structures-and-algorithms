using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class AnimalShelter
    {
        public Animal First { get; set; }
        public Animal Rear { get; set; }

        public void Enqueue(Animal animal)
        {
            Animal temp = First;
            if (First == null) Rear = animal;
            First = animal;
            First.Next = temp;
        }

        public Animal Dequeue(string pref)
        {
            try
            {
                Animal dequeuedAnimal = Rear;

                if (dequeuedAnimal.Name.Equals(pref))
                {
                    Rear = Rear.Next;
                    dequeuedAnimal.Next = null;

                    return dequeuedAnimal;
                }
                else return null;
            }
            catch(NullReferenceException)
            {
                throw new NullReferenceException();
            }
        }
    }
}
