using System;
using System.Collections.Generic;
using System.Text;
namespace Day_6_Stack_and_queue
{
    public class Queue
    {
        Node Front = null;
        public void enqueue(int data){
            Node newnode = new Node(data);
            if(Front == null){
                Front = newnode;
            }else{
                Node temp = Front;
                while(temp.next != null){
                    temp = temp.next;
                }
                temp.next = newnode;
            }
        }
        public void dequeue(){
            if(Front == null){
                System.Console.WriteLine("Queue is empty");
            }else{
                int data = Front.data;
                Front = Front.next;
                System.Console.WriteLine("{0} is removed", data);
            }
        }
          public void Display(){
            if(Front == null){
                System.Console.WriteLine("List is empty");
            }else{
                Node temp = Front;

                while(temp != null){
                    System.Console.Write(temp.data +"=>");
                    temp = temp.next;
                }
                
            }
        }
    }
}