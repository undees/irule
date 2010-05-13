require 'spec_helper'

describe Tcl::Interp do
  it 'evaluates Tcl text' do
    interp = Tcl::Interp.new
    interp.eval('expr 1 + 2').to_i.should == 3
  end

  it 'loads Tcl from a file' do
    tcl_file = File.dirname(__FILE__) + '/example.tcl'
    interp = Tcl::Interp.load_from_file tcl_file
    interp.eval('string length $myString').to_i.should == 5
  end
end
