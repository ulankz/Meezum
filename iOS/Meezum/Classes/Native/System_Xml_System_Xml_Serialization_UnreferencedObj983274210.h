#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_EventArgs3289624707.h"

// System.Object
struct Il2CppObject;
// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.UnreferencedObjectEventArgs
struct  UnreferencedObjectEventArgs_t983274210  : public EventArgs_t3289624707
{
public:
	// System.Object System.Xml.Serialization.UnreferencedObjectEventArgs::unreferencedObject
	Il2CppObject * ___unreferencedObject_1;
	// System.String System.Xml.Serialization.UnreferencedObjectEventArgs::unreferencedId
	String_t* ___unreferencedId_2;

public:
	inline static int32_t get_offset_of_unreferencedObject_1() { return static_cast<int32_t>(offsetof(UnreferencedObjectEventArgs_t983274210, ___unreferencedObject_1)); }
	inline Il2CppObject * get_unreferencedObject_1() const { return ___unreferencedObject_1; }
	inline Il2CppObject ** get_address_of_unreferencedObject_1() { return &___unreferencedObject_1; }
	inline void set_unreferencedObject_1(Il2CppObject * value)
	{
		___unreferencedObject_1 = value;
		Il2CppCodeGenWriteBarrier(&___unreferencedObject_1, value);
	}

	inline static int32_t get_offset_of_unreferencedId_2() { return static_cast<int32_t>(offsetof(UnreferencedObjectEventArgs_t983274210, ___unreferencedId_2)); }
	inline String_t* get_unreferencedId_2() const { return ___unreferencedId_2; }
	inline String_t** get_address_of_unreferencedId_2() { return &___unreferencedId_2; }
	inline void set_unreferencedId_2(String_t* value)
	{
		___unreferencedId_2 = value;
		Il2CppCodeGenWriteBarrier(&___unreferencedId_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
