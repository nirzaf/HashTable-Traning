### Learn how to work with the Hashtable and Dictionary collection types and when to use one in lieu of the other in your applications

    ![](https://images.techhive.com/images/article/2016/05/collections-100663514-primary.idge.jpg?auto=webp&quality=85,70)

Microsoft .Net Framework provides excellent support for working with collections. Collections are used for storage and retrieval of data. You use collections in your application to allocate memory dynamically to store elements and then retrieve them using key or index as and when needed. Basically, a collection represents a set of objects that you can access by iterating each of the elements of the collection.

## **Hashtable**

The types in the System.Collections namespace store data as objects of type Object. Hashtable represents a data structure that can store objects as key value pairs. You can search for a value in an instance of Hashtable class using the corresponding key. Note that both the key and the value that is stored in a Hashtable instance is of the object type. Note that the key cannot be null. You can have a null value stored anyway. The following code listing illustrates how you can store and retrieve key/values from a Hashtable instance.

`static void Main()`

 `{`

 `Hashtable hashTable = new Hashtable();`

 `hashTable.Add(1, "Joydip");`

 `hashTable.Add(2, "James");`

 `hashTable.Add(3, "Steve");`

 `Console.WriteLine("The key / value pairs are:--");`

 `foreach (int key in hashTable.Keys)`

 `{`

 `Console.WriteLine("Key: "+ key + " Value: "+ hashTable[key].ToString());`

 `}`

 `Console.Read();`

 `}`

You can also take advantage of the the GetEnumerator() method of the Hashtable class and then enumerate the collection to retrieve the key/value pairs stored in it. Here's a code snippet that illustrates this.

`IDictionaryEnumerator enumerator = hashTable.GetEnumerator();`

`while (enumerator.MoveNext())`

`{`

`Console.WriteLine("Key: " + enumerator.Key.ToString() + " Value: " + enumerator.Value.ToString());`

`}`

You can also take advantage of the DictionaryEntry class to iterate the items in a Hashtable. The following code snippet illustrates how this can be done.

`Hashtable hashTable = new Hashtable();`

`hashTable.Add(1, "Joydip");`

`hashTable.Add(2, "James");`

`hashTable.Add(3, "Steve");`

`foreach (DictionaryEntry dictionaryEntry in hashTable)`

`{`

 `Console.WriteLine("Key: " + dictionaryEntry.Key.ToString() + " Value: " + dictionaryEntry.Value.ToString());`

`}`

Searching an item in a Hashtable is faster compared to other non-generic collections - let’s understand why. A record in a Hashtable in buckets (each bucket can contain multiple records) using hash keys. The hash key is in turn generated automatically by using a hashing algorithm. [The MSDN states](https://msdn.microsoft.com/en-us/library/system.collections.hashtable(v=vs.110).aspx): "When an element is added to the Hashtable, the element is placed into a bucket based on the hash code of the key. Subsequent lookups of the key use the hash code of the key to search in only one particular bucket, thus substantially reducing the number of key comparisons required to find an element."

## **Dictionary**

Some of the important classes in the System.Collections.Generic namsepace include: List<T>, Queue<T>, HashSet<T>, LinkedList<T>, Stack<T>, LinkedListNode<T> and Dictionary<TKey, TValue>. The Dictionary class in C# represents a generic data structure that can contain keys and values of data. Hence, you can store data of any type in a Dictionary instance.

Note that while the ICollection interface extends the IEnumerable interface, both the IDictionary and IList interfaces extend the ICollection interface. The Dictionary class is contained inside the System.Collections.Generic namespace. In essence, a Dictionary<TKey, TValue> contains a generic collection of key/value pairs. You can take advantage of the Add method of the Dictionary class to store objects in a Dictionary instance. A Dictionary is faster than a Hashtable as it eliminates the boxing and un-boxing overheads.

The following code snippet shows how you can store and retrieve objects inside a Dictionary instance.

`Dictionary<int, string> dictionary = new Dictionary<int, string>();`

`dictionary.Add(1, "Joydip");`

`dictionary.Add(2, "James");`

`dictionary.Add(3, "Steve");`

`foreach (KeyValuePair<int, string> kvp in dictionary)`

`{`

`Console.WriteLine(kvp.Key.ToString() + " - " + kvp.Value.ToString());`

`}`

The basic difference between a Hashtable and Dictionary is that while the former is un-typed and requires boxing and un-boxing overhead, the latter doesn't as it is typed. There is another difference between them. If you use an indexer to retrieve a value from a Hashtable instance and item doesn't exist, you would be returned a null value. On the contrary, if you try to retrieve a non-existent item from a Dictionary instance, an exception will be thrown. Note that neither Hashtable nor Dictionary would guarantee preserving the order of the items in the collection.

While the Hashtable is a weakly-typed data structure, a Dictionary is a strongly typed one. The choice between a Hashtable and Dictionary depends on whether you need a type safe collection. In most cases, a Dictionary is a good choice. To put it simply, a Dictionary is an improved Hashtable. I frequently use Dictionary over a Hashtable.

Joydip Kanjilal is a Microsoft MVP in ASP.Net, as well as a speaker and author of several books and articles. He has more than 20 years of experience in IT including more than 16 years in Microsoft .Net and related technologies.

Copyright © 2016 IDG Communications, Inc.