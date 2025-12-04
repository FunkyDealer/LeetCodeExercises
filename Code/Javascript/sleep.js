//Given a positive integer millis, write an asynchronous function that sleeps for millis milliseconds. It can resolve any value.
//Note that minor deviation from millis in the actual sleep duration is acceptable.

/**
 * @param {number} millis
 * @return {Promise}
 */

async function sleep(millis) {    

    //Creates a new Promise object, which is a way to manage asynchronous operations.
    //The Promise constructor takes a callback function (called the executor) that handles how the Promise will be resolved or rejected.
    return new Promise((resolve) => setTimeout(resolve, millis));
}

/** 
 * let t = Date.now()
 * sleep(100).then(() => console.log(Date.now() - t)) // 100
 */