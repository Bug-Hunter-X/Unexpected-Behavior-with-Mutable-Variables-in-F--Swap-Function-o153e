let swap (x, y) =
    (y, x)

let x, y = swap (10, 20)
printf "%d %d" x y //This will correctly print 20 10