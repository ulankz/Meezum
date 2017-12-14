#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "System_Xml_System_Xml_Serialization_SerializationS1619243689.h"

// System.String
struct String_t;
// System.Type
struct Type_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.Serialization.XmlTypeSerializationSource
struct  XmlTypeSerializationSource_t3069538444  : public SerializationSource_t1619243689
{
public:
	// System.String System.Xml.Serialization.XmlTypeSerializationSource::attributeOverridesHash
	String_t* ___attributeOverridesHash_3;
	// System.Type System.Xml.Serialization.XmlTypeSerializationSource::type
	Type_t * ___type_4;
	// System.String System.Xml.Serialization.XmlTypeSerializationSource::rootHash
	String_t* ___rootHash_5;

public:
	inline static int32_t get_offset_of_attributeOverridesHash_3() { return static_cast<int32_t>(offsetof(XmlTypeSerializationSource_t3069538444, ___attributeOverridesHash_3)); }
	inline String_t* get_attributeOverridesHash_3() const { return ___attributeOverridesHash_3; }
	inline String_t** get_address_of_attributeOverridesHash_3() { return &___attributeOverridesHash_3; }
	inline void set_attributeOverridesHash_3(String_t* value)
	{
		___attributeOverridesHash_3 = value;
		Il2CppCodeGenWriteBarrier(&___attributeOverridesHash_3, value);
	}

	inline static int32_t get_offset_of_type_4() { return static_cast<int32_t>(offsetof(XmlTypeSerializationSource_t3069538444, ___type_4)); }
	inline Type_t * get_type_4() const { return ___type_4; }
	inline Type_t ** get_address_of_type_4() { return &___type_4; }
	inline void set_type_4(Type_t * value)
	{
		___type_4 = value;
		Il2CppCodeGenWriteBarrier(&___type_4, value);
	}

	inline static int32_t get_offset_of_rootHash_5() { return static_cast<int32_t>(offsetof(XmlTypeSerializationSource_t3069538444, ___rootHash_5)); }
	inline String_t* get_rootHash_5() const { return ___rootHash_5; }
	inline String_t** get_address_of_rootHash_5() { return &___rootHash_5; }
	inline void set_rootHash_5(String_t* value)
	{
		___rootHash_5 = value;
		Il2CppCodeGenWriteBarrier(&___rootHash_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
