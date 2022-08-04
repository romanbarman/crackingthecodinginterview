using Structures;
using System;

namespace Chapter03.PetsQueue
{
    public class PetsQueue
    {
        private LinkedListNode<Dog> firtsDog;
        private LinkedListNode<Pet> firstPet;
        private LinkedListNode<Cat> firtsCat;

        private LinkedListNode<Dog> lastDog;
        private LinkedListNode<Pet> lastPet;
        private LinkedListNode<Cat> lastCat;

        public void Enqueue(Pet pet)
        {
            if (firstPet == null)
            {
                firstPet = new LinkedListNode<Pet>(pet);
                lastPet = firstPet;
            }
            else
            {
                lastPet.SetNext(new LinkedListNode<Pet>(pet));
                lastPet = lastPet.Next;
            }

            if (pet is Cat)
            {
                if (firtsCat == null)
                {
                    firtsCat = new LinkedListNode<Cat>(pet as Cat);
                    lastCat = firtsCat;
                }
                else
                {
                    lastCat.SetNext(new LinkedListNode<Cat>(pet as Cat));
                    lastCat = lastCat.Next;
                }
            }

            if (pet is Dog)
            {
                if (firtsDog == null)
                {
                    firtsDog = new LinkedListNode<Dog>(pet as Dog);
                    lastDog = firtsDog;
                }
                else
                {
                    lastDog.SetNext(new LinkedListNode<Dog>(pet as Dog));
                    lastDog = lastDog.Next;
                }
            }
        }

        public Pet DequeueAny()
        {
            if (firstPet == null)
            {
                throw new InvalidOperationException();
            }

            var pet = firstPet.Value;
            firstPet = firstPet.Next;

            if (pet is Dog)
            {
                firtsDog = firtsDog.Next;
            }
            else
            {
                firtsCat = firtsCat.Next;
            }

            CheckIsEmpty();

            return pet;
        }

        public Dog DequeueDog()
        {
            if (firtsDog == null)
            {
                throw new InvalidOperationException();
            }

            var dog = firtsDog.Value;
            firtsDog = firtsDog.Next;

            RemoveFirstPet<Dog>();
            CheckIsEmpty();

            return dog;
        }

        public Cat DequeueCat()
        {
            if (firtsCat == null)
            {
                throw new InvalidOperationException();
            }

            var cat = firtsCat.Value;
            firtsCat = firtsCat.Next;

            RemoveFirstPet<Cat>();
            CheckIsEmpty();

            return cat;
        }

        public void Show()
        {
            var pet = firstPet;

            while (pet != null)
            {
                Console.Write($"{pet.Value} ");
                pet = pet.Next;
            }
        }

        private void CheckIsEmpty()
        {
            if (firstPet == null)
            {
                lastPet = null;
            }

            if (firtsCat == null)
            {
                lastCat = null;
            }

            if (firtsDog == null)
            {
                lastDog = null;
            }
        }

        private void RemoveFirstPet<T>() where T : Pet
        {
            if (firstPet.Value is T)
            {
                firstPet = firstPet.Next;
            }
            else
            {
                var pet = firstPet;

                while (pet.Next != null)
                {
                    if (pet.Next.Value is T)
                    {
                        pet.SetNext(pet.Next.Next);
                        break;
                    }

                    pet = pet.Next;
                }
            }
        }
    }
}
