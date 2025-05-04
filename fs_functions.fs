module fs_functions

let mathManipulation L =
      match L with
      | [] -> 0
      | _  -> let resolution = List.map (fun x -> ((x*2) + 30)) L
              List.reduce (fun x y -> x + y) resolution
              