using System;
using System.Collections.Generic;

namespace Progam
{
    class Post
    {
        static void Main(string[] args)
        {
            string postText = Console.ReadLine();

            Post post = new Post();
            post.Text = postText;
            post.ShowPost();

        }
    }

    class Post
    {
        private string text;
        
        public Post() {            
            Console.WriteLine("¡Nuevo Post!");
        }

        public void ShowPost()
        {
            Console.WriteLine(text);
        }
        
        public string Text {
            get {return text;}
            set {text = value;}
        }
    }
}
