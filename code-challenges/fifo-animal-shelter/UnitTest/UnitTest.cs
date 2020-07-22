using System;
using Xunit;
using FIFOAnimalShelter.Classes;

namespace UnitTest
{
    public class UnitTest
    {
        [Fact]
        public void SuccessfulEnqueue()
        {
            AnimalShelter shelter = new AnimalShelter();

            shelter.Enqueue(new Dog());

            Assert.NotNull(shelter.First);
        }

        [Fact]
        public void SuccessfulMultipleEnqueues()
        {
            AnimalShelter shelter = new AnimalShelter();

            shelter.Enqueue(new Dog());
            shelter.Enqueue(new Cat());
            shelter.Enqueue(new Dog());
            shelter.Enqueue(new Cat());

            Assert.NotNull(shelter.First);
        }

        [Fact]
        public void SuccessfulCatDequeue()
        {
            AnimalShelter shelter = new AnimalShelter();

            shelter.Enqueue(new Cat());
            Animal nextAnimal = shelter.Dequeue("Cat");

            Assert.NotNull(nextAnimal);
        }

        [Fact]
        public void SuccessfulDogDequeue()
        {
            AnimalShelter shelter = new AnimalShelter();

            shelter.Enqueue(new Dog());
            Animal nextAnimal = shelter.Dequeue("Dog");

            Assert.NotNull(nextAnimal);
        }

        [Fact]
        public void SuccessfulMismatchDequeue()
        {
            AnimalShelter shelter = new AnimalShelter();

            shelter.Enqueue(new Cat());
            Animal nextAnimal = shelter.Dequeue("Dog");

            Assert.Null(nextAnimal);
        }

        [Fact]
        public void AttemptNullExceptionDequeue()
        {
            AnimalShelter shelter = new AnimalShelter();

            Assert.Throws<NullReferenceException>(() => shelter.Dequeue("Dog"));
        }
    }
}
