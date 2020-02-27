function squareDigits(num){
  let strNum = String(num);
  let newNum = "";
  for(let i = 0; i < strNum.length; i++) {
    newNum += Math.pow(strNum[i], 2);
  }
  return Number(newNum);
}