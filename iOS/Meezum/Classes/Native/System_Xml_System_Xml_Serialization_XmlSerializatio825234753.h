#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_Object2689449295.h"

// System.Type
struct Type_t;
// System.String
struct String_t;
// System.Xml.Serialization.XmlSerializationReadCallback
struct XmlSerializationReadCallback_t3162327146;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlSerializationReader/WriteCallbackInfo
struct  WriteCallbackInfo_t825234753  : public Il2CppObject
{
public:
	// System.Type System.Xml.Serialization.XmlSerializationReader/WriteCallbackInfo::Type
	Type_t * ___Type_0;
	// System.String System.Xml.Serialization.XmlSerializationReader/WriteCallbackInfo::TypeName
	String_t* ___TypeName_1;
	// System.String System.Xml.Serialization.XmlSerializationReader/WriteCallbackInfo::TypeNs
	String_t* ___TypeNs_2;
	// System.Xml.Serialization.XmlSerializationReadCallback System.Xml.Serialization.XmlSerializationReader/WriteCallbackInfo::Callback
	XmlSerializationReadCallback_t3162327146 * ___Callback_3;

public:
	inline static int32_t get_offset_of_Type_0() { return static_cast<int32_t>(offsetof(WriteCallbackInfo_t825234753, ___Type_0)); }
	inline Type_t * get_Type_0() const { return ___Type_0; }
	inline Type_t ** get_address_of_Type_0() { return &___Type_0; }
	inline void set_Type_0(Type_t * value)
	{
		___Type_0 = value;
		Il2CppCodeGenWriteBarrier(&___Type_0, value);
	}

	inline static int32_t get_offset_of_TypeName_1() { return static_cast<int32_t>(offsetof(WriteCallbackInfo_t825234753, ___TypeName_1)); }
	inline String_t* get_TypeName_1() const { return ___TypeName_1; }
	inline String_t** get_address_of_TypeName_1() { return &___TypeName_1; }
	inline void set_TypeName_1(String_t* value)
	{
		___TypeName_1 = value;
		Il2CppCodeGenWriteBarrier(&___TypeName_1, value);
	}

	inline static int32_t get_offset_of_TypeNs_2() { return static_cast<int32_t>(offsetof(WriteCallbackInfo_t825234753, ___TypeNs_2)); }
	inline String_t* get_TypeNs_2() const { return ___TypeNs_2; }
	inline String_t** get_address_of_TypeNs_2() { return &___TypeNs_2; }
	inline void set_TypeNs_2(String_t* value)
	{
		___TypeNs_2 = value;
		Il2CppCodeGenWriteBarrier(&___TypeNs_2, value);
	}

	inline static int32_t get_offset_of_Callback_3() { return static_cast<int32_t>(offsetof(WriteCallbackInfo_t825234753, ___Callback_3)); }
	inline XmlSerializationReadCallback_t3162327146 * get_Callback_3() const { return ___Callback_3; }
	inline XmlSerializationReadCallback_t3162327146 ** get_address_of_Callback_3() { return &___Callback_3; }
	inline void set_Callback_3(XmlSerializationReadCallback_t3162327146 * value)
	{
		___Callback_3 = value;
		Il2CppCodeGenWriteBarrier(&___Callback_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
