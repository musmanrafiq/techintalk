using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ImageListDemo
{
    public partial class Form1 : Form
    {
        private List<Image> LoadedImages { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // loading images from folder
            LoadImagesFromFolder();

            // initializing images list
            ImageList images = new ImageList();
            images.ImageSize = new Size(130, 40);


            foreach(var image in LoadedImages)
            {
                images.Images.Add(image);
            }

            // setting our listview with the imagelist
            imageList.LargeImageList = images;

            for (int itemIndex = 1; itemIndex <= LoadedImages.Count; itemIndex++)
            {
                imageList.Items.Add(new ListViewItem($"Image {itemIndex}", itemIndex-1));
            }
        }

        private void LoadImagesFromFolder()
        {
            LoadedImages = new List<Image>();
            var index = 1;
            while(index < 10)
            {
                string tempLocation = $@"E:\temp\images\{index}.png";
                var tempImage = Image.FromFile(tempLocation);
                LoadedImages.Add(tempImage);
                index += 1;
            }
        }
    }
}
