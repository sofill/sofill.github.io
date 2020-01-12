# 07 - 클래스로 데이터 타입 정의하기

## 학습 목표

- 클래스를 활용하여 여러 개의 데이터를 한 단위로 묶을 수 있다.
- 클래스와 인스턴스의 관계를 이해한다.
- 인스턴스와 레퍼런스의 관계를 이해한다.
- 레퍼런스 배열을 이해한다.

## 실습 소스 및 결과

- src/main/java/com/sofillmovielang/Movie.java 추가
- src/main/java/com/sofillmovielang/Member.java 추가
- src/main/java/com/sofillmovielang/Board.java 추가
- src/main/java/com/sofillmovielang/App.java 변경
- src/main/java/com/sofillmovielang/App2.java 변경
- src/main/java/com/sofillmovielang/App3.java 변경

## 실습

### 작업1) `나의 해외명작 컬렉션` 데이터를 저장할 데이터 타입을 정의하라.

- Movie.java
    - 수업 데이터를 저장할 새 데이터 타입을 정의한다.
- App1.java
    - Movie 클래스를 사용하여 수업 데이터를 다룬다.
    
App1.java 실행 결과

``` 
=====나의 해외명작 컬렉션=====
제목: 흐르는 강물처럼
개봉일: 1992-10-9
나의 평점: 5
카테고리: 영화
장르: 드라마
감독: 로버트 레드포드
작가: 모름
주연: 크레이그 셰퍼, 브래드 피트
한줄 평가: 인생은 강물처럼 흘러간다. 눈물이 소리없이 흘러내렸다.

계속 입력하시겠습니까? (Y/n) y


제목: 미 비포 유
개봉일: 2016-6-1
나의 평점: 5
카테고리: 영화
장르: 로맨스/멜로
감독: 티아 샤록
작가: 모름
주연: 에밀리아 클라크, 샘 클래플린
한줄 평가: 눈물이 주룩주룩..

계속 입력하시겠습니까? (Y/n) n

================================= 

1.제목 - 흐르는 강물처럼
2.개봉일 - 1992-10-09
3.나의 별점 - 5.0
4.카테고리 - 영화
5.장르 - 드라마
6.감독 - 로버트 레드포드
7.작가 - 모름
8.주연 - 크레이그 셰퍼, 브래드 피트
9.한줄 평가 - 인생은 강물처럼 흘러간다. 눈물이 소리없이 흘러내렸다.

================================= 

1.제목 - 미 비포 유
2.개봉일 - 2016-06-01
3.나의 별점 - 5.0
4.카테고리 - 영화
5.장르 - 로맨스/멜로
6.감독 - 티아 샤록
7.작가 - 모름
8.주연 - 에밀리아 클라크, 샘 클래플린
9.한줄 평가 - 눈물이 주룩주룩..

================================= 
                저장일 : 2020-01-04
```
                

### 작업2) `영화 속 몰랐던 단어` 데이터를 저장할 데이터 타입을 정의하라.

- Word.java
    - 단어 데이터를 저장할 새 데이터 타입을 정의한다.
- App2.java
    - Word 클래스를 사용하여 회원 데이터를 다룬다.

App2.java 실행 결과

```     
    =====영화 속 몰랐던 단어=====
제목: 미 비포 유
언어: 영어
단어: complications
의미: 합병증
품사: 명사
인용: A complications is a problem or difficulty that makes a situation harder to deal with.
번역: 합병증은 상황을 다루기 어렵게 만드는 문제나 난관을 말한다. 
메모: 번역이 좀 이상함
계속 입력하시겠습니까? (Y/n) y


제목: 어떤 영화
언어: 영어
단어: Elephant in the room
의미: 모두 알지만 말하지 않고 있는 문제/언급하기 꺼려지는 문제
품사: 숙어
인용: Racism in America is the elephant in the room.
번역: 미국에서 인종차별은 금기시되는 주제다.
메모: 왜 방 안의 코끼리가 이런 뜻인지는 모르겠음;
계속 입력하시겠습니까? (Y/n) n

================================= 

1.제목 - 미 비포 유
2.언어 - 영어
3.단어 - complications
4.의미 - 합병증
5.품사 - 명사
6.인용 - A complications is a problem or difficulty that makes a situation harder to deal with.
7.번역 - 합병증은 상황을 다루기 어렵게 만드는 문제나 난관을 말한다. 
8.메모 - 번역이 좀 이상함

================================= 

1.제목 - 어떤 영화
2.언어 - 영어
3.단어 - Elephant in the room
4.의미 - 모두 알지만 말하지 않고 있는 문제/언급하기 꺼려지는 문제
5.품사 - 숙어
6.인용 - Racism in America is the elephant in the room.
7.번역 - 미국에서 인종차별은 금기시되는 주제다.
8.메모 - 왜 방 안의 코끼리가 이런 뜻인지는 모르겠음;

================================= 
                저장일 : 2020-01-04

```

### 작업3) `회원` 데이터를 저장할 데이터 타입을 정의하라.

- Member.java
    - 게시글 데이터를 저장할 새 데이터 타입을 정의한다.
- App3.java
    - Member 클래스를 사용하여 게시글 데이터를 다룬다.

App3.java 실행 결과

```      
=====회원 등록=====
아이디: sofill
이름: 이신애
이메일: sofill.lee@gmail.com
암호: 1234
암호 확인: 1234
주소: 서울시 강남구
연락처: 010-5555-5555
계속 입력하시겠습니까? (Y/n) y


아이디: wewe
이름: 이신웅
이메일: wewe@gmail.com
암호: 3333
암호 확인: 3333
주소: 서울시 서초구
연락처: 010-2222-2222
계속 입력하시겠습니까? (Y/n) n

================================= 

1.아이디 - sofill
2.이름 - 이신애
3.이메일 - sofill.lee@gmail.com
4.암호 - 1234
5.암호 확인 - 1234
6.주소 - 서울시 강남구
7.연락처 - 010-5555-5555

================================= 

1.아이디 - wewe
2.이름 - 이신웅
3.이메일 - wewe@gmail.com
4.암호 - 3333
5.암호 확인 - 3333
6.주소 - 서울시 서초구
7.연락처 - 010-2222-2222

================================= 
                저장일 : 2020-01-04
```                 
                