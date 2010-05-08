require 'albacore'

desc "Compiles and then rebuilds the database"
task :default => [:msbuild, :db] do
end

desc "Compile the solution"
msbuild do |msb|
    msb.solution = "src/MyApp.sln"
    msb.path_to_command = File.join(ENV['windir'], 'Microsoft.NET', 'Framework', 'v4.0.30319', 'MSBuild.exe') 
end

desc "Generate the database (requires IronRuby)"
task :db do
  $:.unshift('.\src\MyApp\bin')
  require 'MyApp'
  MyApp::Database.BuildSchema
  puts 'Database rebuilt'
end