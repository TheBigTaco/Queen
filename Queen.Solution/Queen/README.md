# Specs
|Behavior|Input|Output|
|-|-|-|
|Queen will attack if target is in a direct horizontal line|0,1 / 0,2|Successful attack|
|Queen will attack if target is in a direct vertical line|0,1 / 1,1|Successful attack|
|Queen will attack if target is in a direct diagonal line|1,1 / 2,2|Successful attack|
|Queen will not attack if target is not in a direct line|1,1 / 2,3|Failed attack|
|Will only accept numbers|Hello|"Nope"|
