using System.Collections.ObjectModel;
using IndicatorView.Models;

namespace IndicatorView.ViewModels
{
    public class AnimalPageViewModel
    {
        public ObservableCollection<Animal> AnimalCollection { get; } = new ObservableCollection<Animal>
        {
            new Animal
            {
                Name = "Rabbit",
                Details =
                    "Rabbits are small, furry, mammals with long ears, short fluffy tails, and strong, large hind legs. They have 2 pairs of sharp incisors (front teeth), one pair on top and one pair on the bottom. They also have 2 peg teeth behind the top incisors. Their teeth are specifically adapted for gnawing and grow continuously throughout their lives."
            },
            new Animal
            {
                Name = "Deer",
                Details =
                    "Whitetails range in color from reddish brown in warmer months, to grey in the winter and fall. The most recognizable characteristic is the deer’s white under-tail, which is visible when the tail is raised. The males, known as “bucks,” grow new antlers yearly. It is extremely rare for the does (female deer) to grow antlers."
            },
            new Animal
            {
                Name = "Dog",
                Details =
                    "Dogs are domesticated mammals, not natural wild animals. They were originally bred from wolves. They have been bred by humans for a long time, and were the first animals ever to be domesticated. There are different studies that suggest that this happened between 15.000 and 100.000 years before our time."
            },
            new Animal
            {
                Name = "Cat",
                Details =
                    "The cat is a small carnivorous mammal.[1][2] It is the only domesticated species in the family Felidae and often referred to as the domestic cat to distinguish it from wild members of the family.[4] The cat is either a house cat or a farm cat, which are pets, or a feral cat, which ranges freely and avoids human contact."
            },
            new Animal
            {
                Name = "Elephant",
                Details =
                    "Elephant, (family Elephantidae), largest living land animal, characterized by its long trunk (elongated upper lip and nose), columnar legs, and huge head with temporal glands and wide, flat ears. Elephants are grayish to brown in colour, and their body hair is sparse and coarse."
            }
        };

        public ObservableCollection<Animal> ListViewCollection { get; } = new ObservableCollection<Animal>
        {
            new Animal
            {
                Name = "Rabbit"
            },
            new Animal
            {
                Name = "Deer"
            },
            new Animal
            {
                Name = "Dog"
            },
            new Animal
            {
                Name = "Cat"
            },
            new Animal
            {
                Name = "Elephant"
            },
            new Animal
            {
                Name = "Lion"
            },
            new Animal
            {
                Name = "Tiger"
            },
            new Animal
            {
                Name = "Goat"
            },
            new Animal
            {
                Name = "Pig"
            }
        };
    }
}