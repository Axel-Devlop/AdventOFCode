<!DOCTYPE html>
<html>
    <head>
        <title>Day 1</title>
    </head>
    <body>
        <?php 
            $answer = 0;
            $inputArray = file("input.txt");

            foreach($inputArray as $inputLine) {

                $lineNumbersTotal = 0;
                $firstNumberFound = false;
                $secondNumberFound = false;

                for($i = 0; $i < strlen($inputLine); $i++) {
                    if($firstNumberFound == false && is_numeric($inputLine[$i])) {

                        $lineNumbersTotal += $inputLine[$i]*10;
                        $firstNumberFound = true;
                        echo "first = " . $inputLine[$i] . "/";
                    }
                }

                for($i = strlen($inputLine); $i >= 0; $i--) {

                    if( $secondNumberFound == false && is_numeric($inputLine[$i])) {

                        $lineNumbersTotal += $inputLine[$i];
                        $secondNumberFound = true;
                        echo "second = " . $inputLine[$i]. "///";
                    }
                }

                $answer += $lineNumbersTotal;
            }

            echo "The answer is " . $answer;
        ?>
    </body>
</html>