
task :default => [:welcome_to_poker_game, :some_extra_random_task] do
 puts "the end !"
end

task :welcome_to_poker_game do
puts "welcome to my game"
end

task :some_extra_random_task do
puts "here's an extra random task"
end