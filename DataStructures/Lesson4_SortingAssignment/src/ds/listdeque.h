//======================================================================
// VFS: Data Strucrtures And Algorithms
//======================================================================

#if !defined _VFS_LISTDEQUE_H_
#define _VFS_LISTDEQUE_H_

//======================================================================

#include "adt/deque.h"
#include "arraylist.h"
#include "linkedlist.h"

//======================================================================

template <class T>
class ListDeque: public Deque<T>
{
public:

    //-----------------------------------------------------------
    // Constructor
#if !defined USE_LINKEDLIST
    ListDeque( uint32_t const maxSize ):
        mList( maxSize )
#else
    ListDeque( uint32_t const maxSize )
#endif
    {
    }

    //-----------------------------------------------------------
    // Destructor
    virtual ~ListDeque()
    {
    }

    //-----------------------------------------------------------
    // Enqueue entry to the front of the queue.
    virtual bool EnqueueFront( const T& entry ) override
    {
        return mList.Insert( entry, 0 );
    }

    //-----------------------------------------------------------
    // Enqueue entry to the back of the queue.
    virtual bool EnqueueBack( const T& entry ) override
    {
        return mList.Append( entry );
    }

    //-----------------------------------------------------------
    // Copy the front entry.
    virtual bool PeekFront( T& entry ) const override
    {
        return mList.At( entry, 0 );
    }

    //-----------------------------------------------------------
    // Copy the back entry.
    virtual bool PeekBack( T& entry ) const override
    {
        return mList.At( entry, (mList.Size() - 1) );
    }

    //-----------------------------------------------------------
    // Dequeue entry from the front of the queue.
    virtual bool DequeueFront() override
    {
        return mList.Remove( 0 );
    }

    //-----------------------------------------------------------
    // Dequeue entry from the back of the queue.
    virtual bool DequeueBack() override
    {
        return mList.Remove( (mList.Size() - 1) );
    }

    //-----------------------------------------------------------
    // Return current size of the queue.
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
