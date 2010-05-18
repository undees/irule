Gem::Specification.new do |s|
  s.name        = 'irule'
  s.version     = '0.3.1'
  s.platform    = 'universal-dotnet'
  s.authors     = ['Ian Dees']
  s.email       = ['undees@gmail.com']
  s.homepage    = 'http://github.com/undees/irule'
  s.summary     = '.I.ron.RU.by tc.L. .E.xtension'
  s.description = 'Provides a tiny subset of the tcl gem for IronRuby'

  s.required_rubygems_version = '>= 1.3.5'
  s.add_development_dependency 'rspec'

  s.files        = Dir.glob('lib/**/*') + %w(LICENSE.txt README.rst)
  s.require_path = 'lib'
end
