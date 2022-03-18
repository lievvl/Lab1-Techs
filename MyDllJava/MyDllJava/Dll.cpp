#include "pch.h"
#include "Dll.h"

JNIEXPORT jint JNICALL Java_com_company_HelloJNI_Sum
(JNIEnv*, jobject, jint a, jint b) {
	return a + b;
}