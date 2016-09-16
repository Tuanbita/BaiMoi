// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// 
// namespace DSLK
// {
//     class Node
//     {
//         public int age;
//         public string name;
// 
//         public Node next;
//     }
//     class List
//     {
//         Node head=null;
// 
//         public void AddNode()
//         {
//             Node temp = new Node();
// 
//             Console.Write("Get name: "); temp.name=Console.ReadLine();
//             Console.Write("Get age: "); temp.age = int.Parse(Console.ReadLine());
// 
//             //temp.next = null;
//             if (head == null)
//             {
//                 head = temp;
//             }
//             else
//             {
//                 Node current=null;
//                 current = head;
//                 while (current.next != null)
//                 {
//                     current = current.next;
//                 }
//                 current.next = temp;
//             }
//         }
//         public void hienthi()
//         {
//             Node current = head;
// 
//             while(current!=null)
//             {
//                 Console.WriteLine("ten: {0}, tuoi: {1}", current.name, current.age);
//                 current = current.next;
//                
//             }
//         }
// 
// 
//         static void Main(string[] args)
//         {
//             int i;
//             List A=new List();
//             for (i = 0; i < 5; i++)
//             {
//                 A.AddNode();
//             }
//                 A.hienthi();
//             Console.ReadKey();
//         }
//     }
// }
