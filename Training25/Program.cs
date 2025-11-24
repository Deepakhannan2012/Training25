// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T15 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      List<char> list = [];
      MyList<char> myList = new ();
      list.Add ('a');
      list.Add ('b');
      list.Add ('c');
      list.Add ('d');
      myList.Add ('a');
      myList.Add ('b');
      myList.Add ('c');
      myList.Add ('d');
      list[3] = 'k';
      myList[3] = 'k';
      list.Remove ('d');
      myList.Remove ('d');
      list.Insert (0, 'z');
      myList.Insert (0, 'z');
      list.RemoveAt (2);
      myList.RemoveAt (2);
      Write ("Comparing the default list and the custom myList after the given set of operations:" +
             $"\n\nDefault List:\nCount => {list.Count}\nCapacity => {list.Capacity}\nElements => ");
      foreach (var item in list) Write ($"{item} ");
      Write ($"\n\nCustom List:\nCount => {myList.Count}\nCapacity => {myList.Capacity}\nElements => ");
      for (int i = 0; i < myList.Count; i++) Write ($"{myList[i]} ");
   }
}

class MyList<T> {
   T[] mItems;
   int mCount;

   public MyList () {
      mItems = new T[4];
      mCount = 0;
   }

   // Doubles the capacity of the array
   private void Resize () {
      T[] newItems = new T[mItems.Length * 2];
      for (int i = 0; i < mItems.Length; i++)
         newItems[i] = mItems[i];
      mItems = newItems;
   }

   // Returns the number of elements in the list
   public int Count => mCount;

   // Returns the current capacity of the array
   public int Capacity => mItems.Length;

   // Gets or sets the element at a specific index
   public T this[int index] {
      get {
         if (index < 0 || index >= mCount) throw new ArgumentOutOfRangeException (nameof (index), "Index out of range");
         return mItems[index];
      }
      set {
         if (index < 0 || index >= mCount) throw new ArgumentOutOfRangeException (nameof (index), "Index out of range");
         mItems[index] = value;
      }
   }

   // Adds an item to the end of the list
   public void Add (T item) {
      if (mCount == mItems.Length) Resize ();
      mItems[mCount++] = item;
   }

   // Removes the specific item from the list
   public bool Remove (T item) {
      for (int i = 0; i < mCount; i++)
         if (item!.Equals (mItems[i])) {
            RemoveAt (i);
            return true;
         }
      return false;
   }

   // Clears all items from the list
   public void Clear () {
      mItems = new T[4];
      mCount = 0;
   }

   // Inserts an item at the specified index
   public void Insert (int index, T item) {
      if (index < 0 || index > mCount) throw new ArgumentOutOfRangeException (nameof (index));
      if (mCount == mItems.Length) Resize ();
      for (int i = mCount; i > index; i--) mItems[i] = mItems[i - 1];
      mItems[index] = item;
      mCount++;
   }

   // Removes the item at the specified index
   public void RemoveAt (int index) {
      if (index < 0 || index >= mCount) throw new ArgumentOutOfRangeException (nameof (index));
      for (int i = index; i < mCount - 1; i++) mItems[i] = mItems[i + 1];
      mItems[--mCount] = default!;
   }
}
