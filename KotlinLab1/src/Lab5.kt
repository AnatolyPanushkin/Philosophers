fun main(){
    print("Введите число: ")
    var number: String? = readLine()

    if (number!=null)
    println("$number"+"${number.toInt()*2}")
}
