using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;
namespace Day_6_Stack_and_queue
{
    public class Stack
    {
        Node Top = null;

        public void Push(int data){
            Node newnode = new Node(data);
            if(Top == null)
            {
                Top = newnode;
            }else{
                Node temp  = Top;
                Top = newnode;
                Top.next = temp;
            }
        }

        public void Peek(){
            if(Top == null){
                System.Console.WriteLine("List is empty");
            }else{
                System.Console.WriteLine("Top element is " + Top.data);
            }
        }

        public void Pop(){
            if(Top == null){
                System.Console.WriteLine("List is empty");
            }else{
                int removedvalue = Top.data;
                Top = Top.next;
                System.Console.WriteLine("{0} is removed", removedvalue);
            }

        }
        public void Display(){
            if(Top == null){
                System.Console.WriteLine("List is empty");
            }else{
                Node temp = Top;

                while(temp != null){
                    System.Console.Write(temp.data +"=>");
                    temp = temp.next;
                }
                
            }
        }
    }
}