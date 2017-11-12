# C# Collection Fundamentals
![Build Status](https://travis-ci.org/NileshGule/cSharpCollectionFundamentals.svg?branch=master)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/f091b78b4e654f968b98fb273afbb5b0)](https://www.codacy.com/app/vn_nilesh/cSharpCollectionFundamentals?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=NileshGule/cSharpCollectionFundamentals&amp;utm_campaign=Badge_Grade)

This repository contains code for examples from the [C# Collection fundamentals Pluralsight course](https://app.pluralsight.com/library/courses/csharp-collections).

The codebase builds on the examples from the course and incorporates recent changes to C# language as of Nov 2017.The examples use features available in C# 6 & 7 like `String Interpolation` and `Inline Functions`. The examples also try to use a functional style of programming in C# instead of imperative one. Common example of the functional style is usage of LINQ operators over looping constructs like `for` and `foreach`.
The original codebase was built with .Net Framework 4.0 or 4.6. This codebase is built with .Net Core 2.0 framework. Ideally it should work with .net Framework 4.0 and higher but it has not been tested against it.

Examples contain following :
* Arrays
    * [Copy Arrays](Arrays/ArrayCopy.cs)
    * [Array Covarience](Arrays/ArrayCovarience.cs)
    * [Array Enumeration](Arrays/ArrayEnumeration.cs)
    * [Array initialization](Arrays/ArrayInitializer.cs)
    * [Arrays as reference types](Arrays/ArraysAsRefTypes.cs)
    * [Binary Search](Arrays/BinarySearch.cs)
    * [Find Elements](Arrays/FindElements.cs)
    * [Array Enumeration](Arrays/ForEachReadOnly.cs)
    * [Reverse Arrays](Arrays/ReverseArray.cs)
    * [Sort Arrays](Arrays/SortArray.cs)
* Collections
    * [Dynamic Sizing of collection](Collections/AddToList.cs)
    * [Remove items from list](Collections/RemoveFromList.cs)
    * [Read only collections](Collections/ReadOnlyList.cs)
    * [Collection example](Collections/NonBlankStringList.cs)
* Linked List, Stack and Queue
	* [Linked List Example](LinkedList/LinkedListExample.cs)
	* [Stack example](LinkedList/StackExample.cs)
	* [Queue example](LinkedList/QueueExample.cs)
* Dictionaries
	* [Dictionary example](Dictionaries/DictionaryExample.cs)
    * [Dictionary key Equality](Dictionaries/DictionaryKeyEqualityExample.cs)
	* [ReadOnlyDictionary](Dictionaries/ReadOnlyDictionaryExample.cs)
	* [SortedList](Dictionaries/SortedListExample.cs)
	* [SortedDictionary](Dictionaries/SortedDictionaryExample.cs)
	* [KeyedCollection](Dictionaries/KeyedCollectionExample.cs)
* Sets
    * [HashSet example](Sets/HashSetExample.cs)
    * [HashSet Intersect example](Sets/HashSetIntersectExample.cs)
    * [HashSet Union example](Sets/HashSetUnionExample.cs)
    * [HashSet Symmetric example](Sets/HashSetSymmetricExample.cs)
    * [HashSet Difference example](Sets/HashSetDifferenceExample.cs)
    * [HashSet Equals example](Sets/HashSetEqualsExample.cs)
* Enumerators
    * [Enumerator example](Enumerators/EnumeratorExample.cs)
    * [Custom Enumerator example using yield return](Enumerators/CustomEnumerator.cs)