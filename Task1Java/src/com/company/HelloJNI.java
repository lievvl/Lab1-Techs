package com.company;

public class HelloJNI {
    static {
        System.loadLibrary("MyDllJava");
    }

    private native int Sum(int a, int b);

    public static void main(String[] args) {
        System.out.println(new HelloJNI().Sum(1, 2));
    }
}
