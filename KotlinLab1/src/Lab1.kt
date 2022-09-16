fun main(){
    print("Введите чисоло: ")
    val number = readLine()

    print("Результат: ")

    if (number != null) {
        for (index in 0..number.length){
            if (index==3){
                print(number[index])
                break
            }
            print("${number[index]},")
        }
    }
}
