#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_EventArgs3289624707.h"

// System.Xml.XmlAttribute
struct XmlAttribute_t175731005;
// System.Object
struct Il2CppObject;
// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlAttributeEventArgs
struct  XmlAttributeEventArgs_t3859077982  : public EventArgs_t3289624707
{
public:
	// System.Xml.XmlAttribute System.Xml.Serialization.XmlAttributeEventArgs::attr
	XmlAttribute_t175731005 * ___attr_1;
	// System.Int32 System.Xml.Serialization.XmlAttributeEventArgs::lineNumber
	int32_t ___lineNumber_2;
	// System.Int32 System.Xml.Serialization.XmlAttributeEventArgs::linePosition
	int32_t ___linePosition_3;
	// System.Object System.Xml.Serialization.XmlAttributeEventArgs::obj
	Il2CppObject * ___obj_4;
	// System.String System.Xml.Serialization.XmlAttributeEventArgs::expectedAttributes
	String_t* ___expectedAttributes_5;

public:
	inline static int32_t get_offset_of_attr_1() { return static_cast<int32_t>(offsetof(XmlAttributeEventArgs_t3859077982, ___attr_1)); }
	inline XmlAttribute_t175731005 * get_attr_1() const { return ___attr_1; }
	inline XmlAttribute_t175731005 ** get_address_of_attr_1() { return &___attr_1; }
	inline void set_attr_1(XmlAttribute_t175731005 * value)
	{
		___attr_1 = value;
		Il2CppCodeGenWriteBarrier(&___attr_1, value);
	}

	inline static int32_t get_offset_of_lineNumber_2() { return static_cast<int32_t>(offsetof(XmlAttributeEventArgs_t3859077982, ___lineNumber_2)); }
	inline int32_t get_lineNumber_2() const { return ___lineNumber_2; }
	inline int32_t* get_address_of_lineNumber_2() { return &___lineNumber_2; }
	inline void set_lineNumber_2(int32_t value)
	{
		___lineNumber_2 = value;
	}

	inline static int32_t get_offset_of_linePosition_3() { return static_cast<int32_t>(offsetof(XmlAttributeEventArgs_t3859077982, ___linePosition_3)); }
	inline int32_t get_linePosition_3() const { return ___linePosition_3; }
	inline int32_t* get_address_of_linePosition_3() { return &___linePosition_3; }
	inline void set_linePosition_3(int32_t value)
	{
		___linePosition_3 = value;
	}

	inline static int32_t get_offset_of_obj_4() { return static_cast<int32_t>(offsetof(XmlAttributeEventArgs_t3859077982, ___obj_4)); }
	inline Il2CppObject * get_obj_4() const { return ___obj_4; }
	inline Il2CppObject ** get_address_of_obj_4() { return &___obj_4; }
	inline void set_obj_4(Il2CppObject * value)
	{
		___obj_4 = value;
		Il2CppCodeGenWriteBarrier(&___obj_4, value);
	}

	inline static int32_t get_offset_of_expectedAttributes_5() { return static_cast<int32_t>(offsetof(XmlAttributeEventArgs_t3859077982, ___expectedAttributes_5)); }
	inline String_t* get_expectedAttributes_5() const { return ___expectedAttributes_5; }
	inline String_t** get_address_of_expectedAttributes_5() { return &___expectedAttributes_5; }
	inline void set_expectedAttributes_5(String_t* value)
	{
		___expectedAttributes_5 = value;
		Il2CppCodeGenWriteBarrier(&___expectedAttributes_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
