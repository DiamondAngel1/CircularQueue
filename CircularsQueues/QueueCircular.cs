using System;
using System.Collections.Generic;

namespace CircularsQueues{
    public class CircularQueue<T>{
        private T[] queue;
        private int head;
        private int tail;
        private int count;
        private int capacity;
        public CircularQueue(int capacity){
            if (capacity <= 0){
                throw new ArgumentException("Розмір повинен бути більше нуля");
            }
            this.capacity = capacity;
            queue = new T[capacity];
            head = 0;
            tail = 0;
            count = 0;
        }
        public void AddElement(T item){
            if (Full())
            {
                head = (head + 1) % capacity;
                count--;
            }
            queue[tail] = item;
            tail = (tail + 1) % capacity;
            count++;
        }
        public T DelFirst(){
            if (Empty()){
                throw new InvalidOperationException("Черга пуста");
            }
            T item = queue[head];
            head = (head + 1) % capacity;
            count--;
            return item;
        }
        public T First(){
            if (Empty()){
                throw new InvalidOperationException("Черга пуста");
            }
            return queue[head];
        }
        private bool Empty(){
            return count == 0;
        }
        private bool Full(){
            return count == capacity;
        }
        public int Count(){
            return count;
        }
        public void Print(){
            Console.Write("Черга: ");
            for (int i = 0; i < count; i++){
                int index = (head + i) % capacity;
                Console.Write(queue[index] + " ");
            }
            Console.WriteLine();
        }
    }
}