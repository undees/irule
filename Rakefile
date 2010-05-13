desc 'Build the .NET Tcl wrapper DLL on Mono'
task :dll do
  sh 'mcs -target:library lib/irule.cs'
end

desc 'Put the DLL and its Ruby interface into a gem'
task :gem => :dll do
  sh 'igem build irule.gemspec'
end
