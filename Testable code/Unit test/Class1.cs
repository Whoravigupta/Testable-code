
if (defined('UNIT_TESTING') && UNIT_TESTING)
{
    function my_rand($min, $max)
    {
        return $GLOBALS['random_table'][$min][$max];
    }
}
else
{
    function my_rand($min = 0, $max = PHP_INT_MAX)
    {
        if ($max === PHP_INT_MAX)
      {
         $max = getrandmax();
    }
    return rand($min, $max);
}
}