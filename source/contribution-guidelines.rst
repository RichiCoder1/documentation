Contribution Guidelines
=======================

Introduction
------------

So you're thinking about contributing to Cake? Great! It's **really** appreciated.

Where to start?
---------------

Start by either suggest a feature in the `issue list <https://github.com/cake-build/cake/issues>`_ that you want to see in Cake, or assign yourself to an existing feature/bug. Make sure that no one else is working on it already though. It's also appreciated to have some kind of discussion about the issue if it's not an easy fix, to make sure that it's later.

If your suggestion applies to a broad range of users and scenarios, it will be considered for inclusion in the core Cake assemblies.

Make sure that your contribution follows this contribution guide.

Submitting
^^^^^^^^^^

When your contribution is ready, send a pull request. Bonus for topic branches. *Funny .gif will be your reward*. ;)

Coding
------

Dependencies
^^^^^^^^^^^^

The assemblies ``Cake.Core`` and ``Cake.Common`` should have no dependencies except the .NET BCL library. 

Dependencies for ``Cake`` executable is acceptable in specific circumstances. If you want to introduce a dependency to the Cake executable, make sure you bring it up in the issue.

Unit Tests
^^^^^^^^^^

Make sure to run all unit tests before creating a pull request. You code should also have reasonable unit test coverage.

Documentation
^^^^^^^^^^^^^

If your contribution change behavior or adds new functionality, it's really appreciated (but not mandatory) to update the documentation at `https://github.com/cake-build/documentation <https://github.com/cake-build/documentation>`_.

Coding Standards
^^^^^^^^^^^^^^^^

Normal .NET coding guidelines apply. See the `Framework Design Guidelines <http://msdn.microsoft.com/en-us/library/ms229042.aspx>`_ for suggestions.

If you have access to ReSharper, your code should have no ReSharper warnings or errors with the default settings.

License
-------

By contributing to Cake, you assert that:

1. The contribution is your own original work. 
2. You have the right to assign the copyright for the work (it is not owned by your employer, or you have been given copyright assignment in writing). 
3. You license it under the terms applied to the rest of the Cake project.