=====
Irule
=====

Irule, the .I.ron.RU.by tc.L. .E.xtension, is a Ruby library that
provides a minimal wrapper around the Tcl programming language for
IronRuby_.  It mimics the ``load_from_file`` and ``eval`` methods from
its more full-featured cousin, the tcl_ Ruby library.

Prerequisites
-------------
#. Tcl 8.4.
#. Mono or .NET.

Installation
------------

``igem install irule``, or just put ``tcl.rb`` and ``irule.dll``
somewhere in your ``LOAD_PATH``.

Usage
-----

Sample code::

  require 'tcl'

  tcl    = Tcl::Interp.load_from_file 'some.tcl'
  result = tcl.eval 'someTclCode'

.. _IronRuby: http://ironruby.net
.. _tcl: http://rubygems.org/gems/tcl
