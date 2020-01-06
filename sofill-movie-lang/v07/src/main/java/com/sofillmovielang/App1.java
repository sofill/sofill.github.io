package com.sofillmovielang;

import java.sql.Date;
import java.util.Scanner;

public class App1 {
  public static void main(String[] args) {
    Scanner keyboard = new Scanner(System.in);

    class MovieTvshow {
      int number;
      String title;
      String category; // (1.movie 2.tv-show;
      String genre; // (1.mystery 2.thriller 3.romance 4.drama 5.crime 6.fanatasy 7.animation)
      String director;
      String stars; 
      String writer;
      Date releaseDay;
      float myRating;
      String review;

    }

    final int SIZE = 500;
    MovieTvshow[] arrMovies = new MovieTvshow[SIZE]; // 레퍼런스 배열


    System.out.println("=====나의 해외명작 컬렉션=====");

    int count = 0;
    for (int i = 0; i < SIZE; i++) {
      count++;
      MovieTvshow temp = new MovieTvshow(); // 인스턴스 생성

      System.out.print("제목: ");
      temp.title = keyboard.nextLine();

      System.out.print("개봉일: ");
      temp.releaseDay = Date.valueOf(keyboard.next());

      System.out.print("나의 평점: ");
      temp.myRating = keyboard.nextFloat();
      keyboard.nextLine();

      System.out.print("카테고리: ");
      temp.category = keyboard.nextLine();

      System.out.print("장르: ");
      temp.genre = keyboard.nextLine();

      System.out.print("감독: ");
      temp.director = keyboard.nextLine();

      System.out.print("작가: ");
      temp.writer = keyboard.nextLine();

      System.out.print("주연: ");
      temp.stars = keyboard.nextLine();


      System.out.print("한줄 평가: ");
      temp.review = keyboard.nextLine();
      System.out.println();

      arrMovies[i] = temp;

      System.out.print("계속 입력하시겠습니까? (Y/n) ");
      String response = keyboard.nextLine();
      System.out.println();
      if (!response.equalsIgnoreCase("y"))
        break;
      System.out.println();
    }

    for (int i = 0; i < count; i++) {
      System.out.println("================================= ");
      System.out.println();
      System.out.printf("1.제목 - %s\n", arrMovies[i].title);
      System.out.printf("2.개봉일 - %s\n", arrMovies[i].releaseDay);
      System.out.printf("3.나의 별점 - %.1f\n", arrMovies[i].myRating);
      System.out.printf("4.카테고리 - %s\n", arrMovies[i].category);
      System.out.printf("5.장르 - %s\n", arrMovies[i].genre);
      System.out.printf("6.감독 - %s\n", arrMovies[i].director);
      System.out.printf("7.작가 - %s\n", arrMovies[i].writer);
      System.out.printf("8.주연 - %s\n", arrMovies[i].stars);
      System.out.printf("9.한줄 평가 - %s\n", arrMovies[i].review); 
      System.out.println();
    }
    keyboard.close();
    System.out.println("================================= ");
    Date today = new Date(System.currentTimeMillis());
    System.out.println("                저장일 : " + today);
    System.out.println();

  }
}
