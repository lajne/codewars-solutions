var countBits = function(n) {
  let bits = n.toString(2).match(/1/g);
  return bits !== null ? bits.length : 0
};