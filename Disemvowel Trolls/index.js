function disemvowel(str) {
  return str.split('').map((x, i) => { return 'aeiouAEIOU'.indexOf(str[i]) === -1 ? str[i] : null}).join('');
}