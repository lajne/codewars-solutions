function getCount(str) {
  var vowelsCount = 0;
  
  for(var x = 0; x < str.length ; x++) {
    if ('aeiou'.indexOf(str[x]) !== -1) {
      vowelsCount += 1;
    }
  }
  return vowelsCount;
}