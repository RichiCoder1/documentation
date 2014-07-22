How does it work?
=================

Cake uses a `dependency based programming <http://martinfowler.com/articles/rake.html#DependencyBasedProgramming>`_ model just like Rake, FAKE and similar build automation systems where you declare tasks and the dependencies between those. When you execute a task, Cake will construct a directed acyclic graph containing all tasks and execute these in the correct order.

Task execution
--------------

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

This will first execute target `B` and then `A` as expected.

Criterias
---------

You can also control the flow by providing `criterias`. A criteria is a predicate that has to be fulfilled for the task to execute. The criteria does not affect however succeeding task will be executed.

.. code-block:: csharp

   Task("A")
       .WithCriteria(DateTime.Now.Second % 2 == 0)
       .Does(() =>
   {
   });

   Task("B")
      .WithCriteria(() => DateTime.Now.Second % 2 == 0)
      .IsDependentOn("A");
      .Does(() =>
   {
   });

   RunTarget("B");

Task `A`'s criteria will be set when the task is created while Task `B`'s criteria will be evaluated when the task is being executed.