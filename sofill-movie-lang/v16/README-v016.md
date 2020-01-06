# 16 - UI 코드와 데이터 처리 코드를 분리하기

## 학습 목표

- 캡슐화 기법을 이용하여 데이터 처리 코드를 별개의 클래스로 분리할 수 있다.
- 배열 복제를 통해 배열의 크기를 늘릴 수 있다.
- 역할에 따라 클래스를 분리하는 방법과 이점을 이해한다.  

## 실습 소스 및 결과

- src/main/java/com/sofillmovielang/handler/MovieList.java 추가
- src/main/java/com/sofillmovielang/handler/MemberList.java 추가
- src/main/java/com/sofillmovielang/handler/WordList.java 추가
- src/main/java/com/sofillmovielang/handler/MovieHandlerr.java 변경
- src/main/java/com/sofillmovielang/handler/MemberHandler.java 변경
- src/main/java/com/sofillmovielang/handler/WordHandler.java 변경

## 실습

### 작업1) MovieHandler 에서 데이터 처리 코드를 분리하라.

- MovieList.java
    - `MovieHandler`에서 데이터 처리 코드를 이 클래스로 옮긴다. 
    - 기본 생성자와 배열의 초기 크기를 설정하는 생성자를 정의한다.  
    - 영화 데이터 배열을 리턴하는 toArray() 메서드를 정의한다.
    - 영화 데이터를 저장하는 add() 메서드를 정의한다.
- MovieHandler.java 
    - `MovieList` 클래스를 사용하여 데이터를 처리한다. 

### 작업2) WordHandler 에서 데이터 처리 코드를 분리하라. 

- WordList.java
    - `WordHandler`에서 데이터 처리 코드를 이 클래스로 옮긴다. 
    - 기본 생성자와 배열의 초기 크기를 설정하는 생성자를 정의한다.  
    - 단어 데이터 배열을 리턴하는 toArray() 메서드를 정의한다.
    - 단어 데이터를 저장하는 add() 메서드를 정의한다.
- WordHandler.java
    - `WordList` 클래스를 사용하여 데이터를 처리한다. 

### 작업3) MemberHandler 에서 데이터 처리 코드를 분리하라.

- MemberList.java
    - `MemberHandler`에서 데이터 처리 코드를 이 클래스로 옮긴다 . 
    - 기본 생성자와 배열의 초기 크기를 설정하는 생성자를 정의한다.  
    - 회원 데이터 배열을 리턴하는 toArray() 메서드를 정의한다.
    - 회원 데이터를 저장하는 add() 메서드를 정의한다.
- MemberHandler.java
    - `MemberList` 클래스를 사용하여 데이터를 처리한다.  
    
    
