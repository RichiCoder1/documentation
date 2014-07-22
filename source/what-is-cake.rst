What is Cake?
=============

This document will tell you what Cake is.

Description
-----------

Cake is (like you probably already figured out) a build automation system with a C# DSL to do things like compiling code, copy files/folders, running unit tests, compress files and build NuGet packages.

How does it work?
-----------------

Cake uses a dependency based programming model just like Rake, FAKE and similar build automation systems where you declare tasks and the dependencies between those. When you execute a task, Cake will construct a directed acyclic graph containing all tasks and execute these in the correct order.

.. code-block:: csharp

   Task("A")
       .Does(() =>
   {
   });

   Task("B")
       .IsDependentOn("A");
       .Does(() =>
   {
   });

   RunTarget("B");

Goals
-----

The goal of Cake is to be a first class alternative to those who want to write their build scripts in C# instead of Ruby, F# or Powershell.