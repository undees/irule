=====
Irule
=====

Irule, the .I.ron.RU.by tc.L. .E.xtension, is a Ruby library that
provides a minimal wrapper around the Tcl programming language for
IronRuby_.  It mimics the ``load_from_file`` and ``eval`` methods from
its more full-featured cousin, the tcl_ Ruby library.

Prerequisites
-------------
1. IronRuby.
2. Tcl 8.5.
3. Mono or .NET.

Installation
------------

1. ``igem install irule``, or just put ``tcl.rb`` and ``irule.dll``
somewhere in your ``LOAD_PATH``.

2. On Linux or Mac, you might need to add the following to the
``<configuration>`` section of ``/etc/mono/config``::

  <dllmap dll="tcl85" target="tcl8.5"/>

Usage
-----

Sample code::

  require 'tcl'

  tcl    = Tcl::Interp.load_from_file 'some.tcl'
  result = tcl.eval 'someTclCode'

.. _IronRuby: http://ironruby.net
.. _tcl: http://rubygems.org/gems/tcl
