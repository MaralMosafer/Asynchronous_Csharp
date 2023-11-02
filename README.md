# Asynchronous In C# With Examples

- [x] .NET Core 7
- [x] Console
- [x] WinForm
- [x] WPF


 ## Give Me Star
If you find these explanations and examples helpful, please give me a star. Thank you!

## What is Asynchronous programming?
Asynchronous programming is a programming technique that allows code to be executed concurrently without blocking the execution of the calling thread. In other words, asynchronous code can run in the background 


 <p align="center">
<img src="https://i.imgur.com/dBaSKWF.gif" height="20" width="100%">
</p>

 ![Asynchronous](https://www.apriorit.com/wp-content/uploads/2023/04/figure-1-Developing-Reactive-Applications_-Asynchronous-Programming-in-Rust-vs-Coroutines-in-C.png)
 
<p align="center">
<img src="https://i.imgur.com/dBaSKWF.gif" height="20" width="100%">
</p>

> Synchronous, sometimes called “sync,” and asynchronous, also known as “async,” are two different .

>> Asynchronous is a non-blocking architecture, so the execution of one task isn’t dependent on another. Tasks can run simultaneously.

>> Synchronous is a blocking architecture, so the execution of each operation depends on completing the one before it. Each task requires an answer before moving on to the next iteration.

#### The differences between asynchronous and synchronous include:

- Async is multi-thread, which means operations or programs can run in parallel.
- Sync is a single-thread, so only one operation or program will run at a time.
- Async is non-blocking, which means it will send multiple requests to a server.
- Sync is blocking — it will only send the server one request at a time and wait for that request to be answered by the server.
- Async increases throughput because multiple operations can run at the same time.
- Sync is slower and more methodical.

<p align="center">
<img src="https://i.imgur.com/dBaSKWF.gif" height="20" width="100%">
</p>

### When to use async programming 🤔
Asynchronous programming is critical to programming independent tasks.

For instance, asynchronous programs are ideal for development projects with many iterations. Asynchronous programming will keep development moving forward because steps don’t have to follow a fixed sequence.

Responsive UI is a great use case for asynchronous planning. Take, for example, a shopping app. When a user pulls up their order, the font size should increase. Instead of first waiting to load the history and update the font size, asynchronous programming can make both actions happen simultaneously.


### When to use sync programming 🤔
Asynchronous programming is relatively complex. It can overcomplicate things and make code difficult to read. On the other hand, synchronous programming is fairly straightforward; its code is easier to write and doesn’t require tracking and measuring process flows (as async does).

Because tasks depend on each other, you have to know if they can run independently without interrupting each other.

Synchronous programming could also be appropriate for a customer-facing shopping app. Users want to buy all their items together rather than individually when checking out online. Instead of completing an order every time the user adds something to their cart, synchronous programming ensures that the payment method and shipping destination for all items are selected at the same time.

<p align="center">
<img src="https://i.imgur.com/dBaSKWF.gif" height="20" width="100%">
</p>

<p align="center">
<img src="https://media.tenor.com/c3CBzmFnqHYAAAAi/hug.gif" width="50">
You can easily practice with this project to learn async well. Enjoy it :)
<img src="https://media.tenor.com/c3CBzmFnqHYAAAAi/hug.gif" width="50">
</p>
