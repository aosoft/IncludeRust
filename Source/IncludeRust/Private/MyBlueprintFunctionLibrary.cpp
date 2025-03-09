// Fill out your copyright notice in the Description page of Project Settings.


#include "MyBlueprintFunctionLibrary.h"

#include "RustLib2.h"

int UMyBlueprintFunctionLibrary::Add(int Left, int Right)
{
	return add2(Left, Right);
}
