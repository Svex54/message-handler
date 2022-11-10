# message-handler
Test task from System A generates messages (simple strings) in random way. That system may generate N messages per second and then be idle for hours. Every message has its own priority. System B can process messages in some way, e.g. by sending them to stdout/console. Message processing logic is very slow, it is limited by 1 message/second.
