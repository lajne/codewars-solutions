function createPhoneNumber(numbers){
  let match = String(numbers).replace(/\D/g, '').match(/^(\d{3})(\d{3})(\d{4})$/)
  if (match) {
    return '(' + match[1] + ') ' + match[2] + '-' + match[3]
  }
  return null
}