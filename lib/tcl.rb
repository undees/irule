require File.dirname(__FILE__) + '/irule.dll'

module Tcl
  class Interp
    def initialize
      @interp = Irule::TclInterp.new
    end

    def eval(text)
      @interp.eval text
    end

    def self.load_from_file(file)
      interp = Interp.new
      interp.eval IO.read(file)
      interp
    end
  end
end
