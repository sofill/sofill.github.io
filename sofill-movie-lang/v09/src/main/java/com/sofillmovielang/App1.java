package com.sofillmovielang;

import java.sql.Date;
import java.util.Scanner;

public class App1 {
  // 메인 바깥으로 보낼 때 static 붙이는 이유 : 다른 메서드들과 공유하기 위한 표시
  static Scanner keyboard = new Scanner(System.in);

  static class Movie {
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
  static final int MOVIENTV_SIZE = 500;
  static Movie[] arrMovies = new Movie[MOVIENTV_SIZE]; // 레퍼런스 배열
  static int movieNTv_count = 0;


  static class Word {
    String title;
    String lang;
    String word;
    String wordClass;
    String meaning;
    String quote;
    String translation;
    String memo;
  }
  static final int WORD_SIZE = 500;
  static Word[] arrWord = new Word[WORD_SIZE]; // 레퍼런스 배열
  static int word_count = 0;


  static class Member {
    String id;
    String name;
    String email;
    String password;
    String password2;
    String address;
    String phoneNumber;
  }
  static final int MEMBER_SIZE = 500;
  static Member[]  arrMember = new Member[MEMBER_SIZE];
  static int member_count = 0;


  public static void main(String[] args) {

    String command;

    do {
      System.out.print("\n명령> ");
      command = keyboard.nextLine();
      System.out.println();

      switch (command){
        case "movie/add":
          // 분리된 코드(메서드)를 실행(호출)시킨다.
          // 메서드 호출; method call
          addMovie();
          break;


        case "movie/list":
          listMovie();
          break;


        case "word/add":
          addWord();
          break;

        case "word/list":
          listWord();
          break;

        case "member/add":
          addMember();
          break;

        case "member/list":
          listMember();
          break;

        default:
          if (!command.equalsIgnoreCase("quit")) {
            System.out.println("실행할 수 없는 명령입니다." );
          }
      }
    } while(!command.equalsIgnoreCase("quit"));

    System.out.println("잘가요~!");

    keyboard.close();
  }

  static void addMovie() {
    System.out.println("=====나의 해외명작 컬렉션=====");
    System.out.println();
    for (int i = 0; i < MOVIENTV_SIZE; i++) {
      movieNTv_count++;
      Movie temp = new Movie(); // 인스턴스 생성

      System.out.print("1.제목: ");
      temp.title = keyboard.nextLine();

      System.out.print("2.개봉일: ");
      temp.releaseDay = Date.valueOf(keyboard.next());

      System.out.print("3.나의 평점: ");
      temp.myRating = keyboard.nextFloat();
      keyboard.nextLine();

      System.out.print("4.카테고리: ");
      temp.category = keyboard.nextLine();

      System.out.print("5.장르: ");
      temp.genre = keyboard.nextLine();

      System.out.print("6.감독: ");
      temp.director = keyboard.nextLine();

      System.out.print("7.작가: ");
      temp.writer = keyboard.nextLine();

      System.out.print("8.주연: ");
      temp.stars = keyboard.nextLine();

      System.out.print("9.한줄 평가: ");
      temp.review = keyboard.nextLine();

      System.out.println();
      arrMovies[i] = temp;

      System.out.print("계속 입력하시겠습니까? (Y/n) ");
      String response = keyboard.nextLine();
      System.out.println();
      if (!response.equalsIgnoreCase("y"))
        break;
      System.out.println("-------------------");
      System.out.println();
    }
  }
  static void listMovie() {
    for (int i = 0; i < movieNTv_count; i++) {
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
    System.out.println("================================= ");
    Date today1 = new Date(System.currentTimeMillis());
    System.out.println("                출력일 : " + today1);
    System.out.println();
  }

  static void addWord() {
    System.out.println("=====영화 속 몰랐던 단어=====");
    System.out.println();
    for (int i = 0; i < WORD_SIZE; i++) {
      word_count++;
      Word temp = new Word(); // 인스턴스 생성

      System.out.print("1.제목: ");
      temp.title = keyboard.nextLine();

      System.out.print("2.언어: ");
      temp.lang = keyboard.nextLine();

      System.out.print("3.단어: ");
      temp.word = keyboard.nextLine();

      System.out.print("4.의미: ");
      temp.meaning = keyboard.nextLine();

      System.out.print("5.품사: ");
      temp.wordClass = keyboard.nextLine();

      System.out.print("6.인용: ");
      temp.quote = keyboard.nextLine();

      System.out.print("7.번역: ");
      temp.translation = keyboard.nextLine();

      System.out.print("8.메모: ");
      temp.memo = keyboard.nextLine();

      arrWord[i] = temp;

      System.out.print("계속 입력하시겠습니까? (Y/n) ");
      String response = keyboard.nextLine();

      System.out.println();
      if (!response.equalsIgnoreCase("y"))
        break;
      System.out.println("-------------------");
      System.out.println();
    }
  } 

  static void listWord() {
    for (int i = 0; i < word_count; i++) {
      System.out.println("================================= ");
      System.out.println();
      System.out.printf("1.제목 - %s\n", arrWord[i].title);
      System.out.printf("2.언어 - %s\n", arrWord[i].lang);
      System.out.printf("3.단어 - %s\n", arrWord[i].word);
      System.out.printf("4.의미 - %s\n", arrWord[i].meaning);
      System.out.printf("5.품사 - %s\n", arrWord[i].wordClass);
      System.out.printf("6.인용 - %s\n", arrWord[i].quote);
      System.out.printf("7.번역 - %s\n", arrWord[i].translation);
      System.out.printf("8.메모 - %s\n", arrWord[i].memo); 
      System.out.println();
    }
    System.out.println("================================= ");
    Date today2 = new Date(System.currentTimeMillis());
    System.out.println("                출력일 : " + today2);
    System.out.println();
  }

  static void addMember() {

    System.out.println("=====백업을 위한 멤버 등록=====");
    System.out.println();
    for (int i = 0; i < MEMBER_SIZE; i++) {
      member_count++;
      Member temp = new Member();

      System.out.print("1.아이디: ");
      temp.id = keyboard.nextLine();

      System.out.print("2.이름: ");
      temp.name = keyboard.nextLine();

      System.out.print("3.이메일: ");
      temp.email = keyboard.nextLine();

      System.out.print("4.암호: ");
      temp.password = keyboard.nextLine();

      System.out.print("5.암호 확인: ");
      temp.password2 = keyboard.nextLine();

      System.out.print("6.주소: ");
      temp.address = keyboard.nextLine();

      System.out.print("7.연락처: ");
      temp.phoneNumber = keyboard.nextLine();

      arrMember[i] = temp;

      System.out.print("계속 입력하시겠습니까? (Y/n) ");
      String response = keyboard.nextLine();
      System.out.println();
      if (!response.equalsIgnoreCase("y"))
        break;
      System.out.println("-------------------");
      System.out.println();
    }
  }

  static void listMember() {
    for (int i = 0; i < member_count; i++) {
      System.out.println("================================= ");
      System.out.println();
      System.out.printf("1.아이디 - %s\n", arrMember[i].id);
      System.out.printf("2.이름 - %s\n", arrMember[i].name);
      System.out.printf("3.이메일 - %s\n", arrMember[i].email);
      System.out.printf("4.암호 - %s\n", arrMember[i].password);
      System.out.printf("5.암호 확인 - %s\n", arrMember[i].password2);
      System.out.printf("6.주소 - %s\n", arrMember[i].address);
      System.out.printf("7.연락처 - %s\n", arrMember[i].phoneNumber);
      System.out.println();
    }
    System.out.println("================================= ");
    Date today3 = new Date(System.currentTimeMillis());
    System.out.println("                출력일 : " + today3);
    System.out.println();
  }

}

