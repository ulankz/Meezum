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
// System.Xml.Serialization.XmlSerializationWriteCallback
struct XmlSerializationWriteCallback_t3502762961;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlSerializationWriter/WriteCallbackInfo
struct  WriteCallbackInfo_t1544550059  : public Il2CppObject
{
public:
	// System.Type System.Xml.Serialization.XmlSerializationWriter/WriteCallbackInfo::Type
	Type_t * ___Type_0;
	// System.String System.Xml.Serialization.XmlSerializationWriter/WriteCallbackInfo::TypeName
	String_t* ___TypeName_1;
	// System.String System.Xml.Serialization.XmlSerializationWriter/WriteCallbackInfo::TypeNs
	String_t* ___TypeNs_2;
	// System.Xml.Serialization.XmlSerializationWriteCallback System.Xml.Serialization.XmlSerializationWriter/WriteCallbackInfo::Callback
	XmlSerializationWriteCallback_t3502762961 * ___Callback_3;

public:
	inline static int32_t get_offset_of_Type_0() { return static_cast<int32_t>(offsetof(WriteCallbackInfo_t1544550059, ___Type_0)); }
	inline Type_t * get_Type_0() const { return ___Type_0; }
	inline Type_t ** get_address_of_Type_0() { return &___Type_0; }
	inline void set_Type_0(Type_t * value)
	{
		___Type_0 = value;
		Il2CppCodeGenWriteBarrier(&___Type_0, value);
	}

	inline static int32_t get_offset_of_TypeName_1() { return static_cast<int32_t>(offsetof(WriteCallbackInfo_t1544550059, ___TypeName_1)); }
	inline String_t* get_TypeName_1() const { return ___TypeName_1; }
	inline String_t** get_address_of_TypeName_1() { return &___TypeName_1; }
	inline void set_TypeName_1(String_t* value)
	{
		___TypeName_1 = value;
		Il2CppCodeGenWriteBarrier(&___TypeName_1, value);
	}

	inline static int32_t get_offset_of_TypeNs_2() { return static_cast<int32_t>(offsetof(WriteCallbackInfo_t1544550059, ___TypeNs_2)); }
	inline String_t* get_TypeNs_2() const { return ___TypeNs_2; }
	inline String_t** get_address_of_TypeNs_2() { return &___TypeNs_2; }
	inline void set_TypeNs_2(String_t* value)
	{
		___TypeNs_2 = value;
		Il2CppCodeGenWriteBarrier(&___TypeNs_2, value);
	}

	inline static int32_t get_offset_of_Callback_3() { return static_cast<int32_t>(offsetof(WriteCallbackInfo_t1544550059, ___Callback_3)); }
	inline XmlSerializationWriteCallback_t3502762961 * get_Callback_3() const { return ___Callback_3; }
	inline XmlSerializationWriteCallback_t3502762961 ** get_address_of_Callback_3() { return &___Callback_3; }
	inline void set_Callback_3(XmlSerializationWriteCallback_t3502762961 * value)
	{
		___Callback_3 = value;
		Il2CppCodeGenWriteBarrier(&___Callback_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
