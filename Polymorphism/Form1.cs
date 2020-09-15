using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/***************************************************************
* Name        : Polymorphism
* Author      : Kabrina Brady
* Created     : 10/27/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work
* Description : Each button creates an animal. Animal is general, Dog and Cat are specific types of animals.
*               Input:  Button clicks
*               Output: MessageBoxes
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

    //NOTE: No input validation needed because the user doesn't input any data.

namespace Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ShowAnimalInfo method accepts Animal object as argument. It displays the object's species and calls its MakeSound method
        private void ShowAnimalInfo(Animal animal)
        {
            MessageBox.Show("Species: " + animal.Species);
            animal.MakeSound();
        }

        //creates an animal
        private void CreateAnimalButton_Click(object sender, EventArgs e)
        {
            Animal myAnimal = new Animal("Regular animal");
            ShowAnimalInfo(myAnimal);
        }

        //creates a dog
        private void CreateDogButton_Click(object sender, EventArgs e)
        {
            Dog myDog = new Dog("Fido");
            MessageBox.Show("The dog's name is " + myDog.Name);
            ShowAnimalInfo(myDog);
        }

        //creates a cat
        private void CreateCatButton_Click(object sender, EventArgs e)
        {
            Cat myCat = new Cat("Kitty");
            MessageBox.Show("The cat's name is " + myCat.Name);
            ShowAnimalInfo(myCat);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //closes form
        }
    }
}
