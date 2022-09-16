fun main(){
    var days:Int = 2642

    var years:Int = days/365

    var weaks = (days-years*365)/7

    var resultDays:Int = ((days-years*365)-weaks*7)

    print("Лет:${years},недель:${weaks},дней:${resultDays}")

}