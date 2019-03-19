//======================================================================
// VFS: Data Strucrtures And Algorithms
//======================================================================

#if !defined _VFS_LISTSTACK_H_
#define _VFS_LISTSTACK_H_

//======================================================================

#include "adt/stack.h"
#include "arraylist.h"
#include "linkedlist.h"

//======================================================================

template <class T>
class ListStack: public Stack<T>
{
public:

    //-----------------------------------------------------------
    // Constructor
#if !defined USE_LINKEDLIST 
    ListStack( uint32_t const maxSize ):
        mList( maxSize )
#else
    ListStack( uint32_t const maxSize )
#endif
    {
    }

    //-----------------------------------------------------------
    // Destructor
    virtual ~ListStack()
    {
    }

    //-----------------------------------------------------------
    // Push entry to the top of the stack.
    virtual bool Push( const T& entry ) override
    {
        return mList.Append( entry );
    }

    //-----------------------------------------------------------
    // Copy the next entry to be popped.
    virtual bool Peek( T& entry ) const override
    {
        return mList.At( entry, (mList.Size() - 1) );
    }

    //-----------------------------------------------------------
    // Pop entry from the top of the stack.
    virtual bool Pop() override
    {
        return mList.Remove( (mList.Size() - 1) );
    }

    //-----------------------------------------------------------
    // Return current size of stack.
    virtual uint32_t Size() const override
    {
        return mList.Size();
    }

    //-----------------------------------------------------------
    // Dump contents to stdout.
    virtual void Dump() const override
    {
        return mList.Dump();
    }

protected:

#if defined USE_LINKEDLIST
    LinkedList<T> mList;
#else
    ArrayList<T> mList;
#endif
};

//======================================================================

#endif

//======================================================================
