class CarTwo {
  String color; // 색상
  String gearType; // 변속기 종류 - auto(자동), manual(수동)
  int door; // 문의 개수

  // CarTwo(String color, String gearType, int door)를 호출
  CarTwo() {
    this("white", "auto", 4);
  }

  CarTwo(String color) {
    this(color, "auto", 4);
  }

  CarTwo(String color, String gearType, int door) {
    this.color = color;
    this.gearType = gearType;
    this.door = door;
  }
}


class CarTest2 {
  public static void main(String[] args) {
    CarTwo c1 = new CarTwo();
    CarTwo c2 = new CarTwo("blue");

    System.out
        .println("c1의 color = " + c1.color + ", gearType = " + c1.gearType + ", door = " + c1.door);
    System.out
        .println("c2의 color = " + c2.color + ", gearType = " + c2.gearType + ", door = " + c2.door);
  }
}
