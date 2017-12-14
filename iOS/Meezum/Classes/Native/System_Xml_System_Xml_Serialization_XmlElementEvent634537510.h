#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "mscorlib_System_EventArgs3289624707.h"

// System.Xml.XmlElement
struct XmlElement_t2877111883;
// System.Object
struct Il2CppObject;
// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlElementEventArgs
struct  XmlElementEventArgs_t634537510  : public EventArgs_t3289624707
{
public:
	// System.Xml.XmlElement System.Xml.Serialization.XmlElementEventArgs::attr
	XmlElement_t2877111883 * ___attr_1;
	// System.Int32 System.Xml.Serialization.XmlElementEventArgs::lineNumber
	int32_t ___lineNumber_2;
	// System.Int32 System.Xml.Serialization.XmlElementEventArgs::linePosition
	int32_t ___linePosition_3;
	// System.Object System.Xml.Serialization.XmlElementEventArgs::obj
	Il2CppObject * ___obj_4;
	// System.String System.Xml.Serialization.XmlElementEventArgs::expectedElements
	String_t* ___expectedElements_5;

public:
	inline static int32_t get_offset_of_attr_1() { return static_cast<int32_t>(offsetof(XmlElementEventArgs_t634537510, ___attr_1)); }
	inline XmlElement_t2877111883 * get_attr_1() const { return ___attr_1; }
	inline XmlElement_t2877111883 ** get_address_of_attr_1() { return &___attr_1; }
	inline void set_attr_1(XmlElement_t2877111883 * value)
	{
		___attr_1 = value;
		Il2CppCodeGenWriteBarrier(&___attr_1, value);
	}

	inline static int32_t get_offset_of_lineNumber_2() { return static_cast<int32_t>(offsetof(XmlElementEventArgs_t634537510, ___lineNumber_2)); }
	inline int32_t get_lineNumber_2() const { return ___lineNumber_2; }
	inline int32_t* get_address_of_lineNumber_2() { return &___lineNumber_2; }
	inline void set_lineNumber_2(int32_t value)
	{
		___lineNumber_2 = value;
	}

	inline static int32_t get_offset_of_linePosition_3() { return static_cast<int32_t>(offsetof(XmlElementEventArgs_t634537510, ___linePosition_3)); }
	inline int32_t get_linePosition_3() const { return ___linePosition_3; }
	inline int32_t* get_address_of_linePosition_3() { return &___linePosition_3; }
	inline void set_linePosition_3(int32_t value)
	{
		___linePosition_3 = value;
	}

	inline static int32_t get_offset_of_obj_4() { return static_cast<int32_t>(offsetof(XmlElementEventArgs_t634537510, ___obj_4)); }
	inline Il2CppObject * get_obj_4() const { return ___obj_4; }
	inline Il2CppObject ** get_address_of_obj_4() { return &___obj_4; }
	inline void set_obj_4(Il2CppObject * value)
	{
		___obj_4 = value;
		Il2CppCodeGenWriteBarrier(&___obj_4, value);
	}

	inline static int32_t get_offset_of_expectedElements_5() { return static_cast<int32_t>(offsetof(XmlElementEventArgs_t634537510, ___expectedElements_5)); }
	inline String_t* get_expectedElements_5() const { return ___expectedElements_5; }
	inline String_t** get_address_of_expectedElements_5() { return &___expectedElements_5; }
	inline void set_expectedElements_5(String_t* value)
	{
		___expectedElements_5 = value;
		Il2CppCodeGenWriteBarrier(&___expectedElements_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
