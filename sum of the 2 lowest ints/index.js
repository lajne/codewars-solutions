function sumTwoSmallestNumbers(numbers) {  
  let sum = 0;
  let newArr = [];
  
  numbers.forEach((num, i) => {
    if(num >= 0) {
      newArr.push(num);
      newArr.sort((a, b) => {
        return a - b;
      })
    }
    sum = newArr[0] + newArr[1];
  })
  return sum
}